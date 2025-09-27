﻿using System;
using System.Collections.Generic;
using System.Linq;

public class ViolationsMatcher
{
    private List<string> _searchStrings;

    public ViolationsMatcher(List<string> searchStrings)
    {
        _searchStrings = searchStrings ?? throw new ArgumentNullException(nameof(searchStrings));
    }

    /// <summary>
    /// Finds total number of instances of any search strings in the given text (case-sensitive)
    /// </summary>
    /// <param name="text">Text to search in</param>
    /// <returns>Total count of all matches</returns>
    public int CountMatches(string text)
    {
        return CountMatches(text, StringComparison.Ordinal);
    }

    /// <summary>
    /// Finds total number of instances of any search strings in the given text
    /// </summary>
    /// <param name="text">Text to search in</param>
    /// <param name="comparisonType">String comparison type (case-sensitive, case-insensitive, etc.)</param>
    /// <returns>Total count of all matches</returns>
    public int CountMatches(string text, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(text))
            return 0;

        var allMatches = GetAllMatches(text, comparisonType);
        return allMatches.Count;
    }

    /// <summary>
    /// Gets detailed match information including which strings were found and how many times
    /// </summary>
    /// <param name="text">Text to search in</param>
    /// <param name="comparisonType">String comparison type</param>
    /// <returns>Dictionary with search string as key and count as value</returns>
    public Dictionary<string, int> GetMatchDetails(string text, StringComparison comparisonType = StringComparison.Ordinal)
    {
        var results = new Dictionary<string, int>();

        if (string.IsNullOrEmpty(text))
            return results;

        var allMatches = GetAllMatches(text, comparisonType);

        foreach (var match in allMatches)
        {
            if (results.ContainsKey(match.SearchString))
                results[match.SearchString]++;
            else
                results[match.SearchString] = 1;
        }

        return results;
    }

    /// <summary>
    /// Updates the list of search strings
    /// </summary>
    /// <param name="searchStrings">New list of strings to search for</param>
    public void UpdateSearchStrings(List<string> searchStrings)
    {
        _searchStrings = searchStrings ?? throw new ArgumentNullException(nameof(searchStrings));
    }

    /// <summary>
    /// Adds a new search string to the existing list
    /// </summary>
    /// <param name="searchString">String to add</param>
    public void AddSearchString(string searchString)
    {
        if (!string.IsNullOrEmpty(searchString))
        {
            _searchStrings.Add(searchString);
        }
    }

    /// <summary>
    /// Gets the current list of search strings
    /// </summary>
    public List<string> GetSearchStrings()
    {
        return new List<string>(_searchStrings);
    }

    /// <summary>
    /// Gets the context around each match as a single formatted string
    /// </summary>
    /// <param name="text">Text to search in</param>
    /// <param name="contextLength">Number of characters to show before and after each match</param>
    /// <param name="comparisonType">String comparison type</param>
    /// <returns>Formatted string showing all matches with their context</returns>
    public string GetMatchesWithContext(string text, int contextLength = 30, StringComparison comparisonType = StringComparison.Ordinal)
    {
        if (string.IsNullOrEmpty(text))
            return "No text provided.";

        var allMatches = GetAllMatches(text, comparisonType);

        if (allMatches.Count == 0)
            return "No matches found.";

        var result = new System.Text.StringBuilder();
        result.AppendLine($"Found {allMatches.Count} match(es):\n");

        for (int i = 0; i < allMatches.Count; i++)
        {
            var match = allMatches[i];

            // Calculate context boundaries
            int contextStart = Math.Max(0, match.Position - contextLength);
            int contextEnd = Math.Min(text.Length, match.Position + match.Length + contextLength);

            // Extract context
            string beforeContext = text.Substring(contextStart, match.Position - contextStart);
            string matchedText = text.Substring(match.Position, match.Length);
            string afterContext = text.Substring(match.Position + match.Length, contextEnd - (match.Position + match.Length));

            // Add ellipsis if context is truncated
            string beforeEllipsis = contextStart > 0 ? "..." : "";
            string afterEllipsis = contextEnd < text.Length ? "..." : "";

            // Format the result
            result.AppendLine($"Match #{i + 1}: '{match.SearchString}' at position {match.Position}");
            result.AppendLine($"Context: {beforeEllipsis}{beforeContext}[{matchedText}]{afterContext}{afterEllipsis}");
            result.AppendLine();
        }

        return result.ToString().TrimEnd();
    }

    /// <summary>
    /// Gets matches with context as a list of structured objects
    /// </summary>
    /// <param name="text">Text to search in</param>
    /// <param name="contextLength">Number of characters to show before and after each match</param>
    /// <param name="comparisonType">String comparison type</param>
    /// <returns>List of match context objects</returns>
    public List<MatchContext> GetMatchContexts(string text, int contextLength = 30, StringComparison comparisonType = StringComparison.Ordinal)
    {
        var results = new List<MatchContext>();

        if (string.IsNullOrEmpty(text))
            return results;

        var allMatches = GetAllMatches(text, comparisonType);

        foreach (var match in allMatches)
        {
            // Calculate context boundaries
            int contextStart = Math.Max(0, match.Position - contextLength);
            int contextEnd = Math.Min(text.Length, match.Position + match.Length + contextLength);

            // Extract context
            string beforeContext = text.Substring(contextStart, match.Position - contextStart);
            string matchedText = text.Substring(match.Position, match.Length);
            string afterContext = text.Substring(match.Position + match.Length, contextEnd - (match.Position + match.Length));

            results.Add(new MatchContext
            {
                SearchString = match.SearchString,
                MatchedText = matchedText,
                Position = match.Position,
                BeforeContext = beforeContext,
                AfterContext = afterContext,
                FullContext = $"{(contextStart > 0 ? "..." : "")}{beforeContext}[{matchedText}]{afterContext}{(contextEnd < text.Length ? "..." : "")}"
            });
        }

        return results;
    }

    private List<MatchInfo> GetAllMatches(string text, StringComparison comparisonType)
    {
        if (string.IsNullOrEmpty(text))
            return new List<MatchInfo>();

        // Get all search strings sorted by length (longest first) to prioritize longer matches
        var sortedSearchStrings = _searchStrings.Where(s => !string.IsNullOrEmpty(s))
                                               .OrderByDescending(s => s.Length)
                                               .ToList();

        var allMatches = new List<MatchInfo>();

        foreach (string searchString in sortedSearchStrings)
        {
            int startIndex = 0;
            while (startIndex < text.Length)
            {
                int index = text.IndexOf(searchString, startIndex, comparisonType);
                if (index == -1)
                    break;

                // Check if this is an exact match (not part of another word/symbol)
                if (IsExactMatch(text, searchString, index))
                {
                    allMatches.Add(new MatchInfo
                    {
                        SearchString = searchString,
                        Position = index,
                        Length = searchString.Length
                    });
                }

                startIndex = index + 1;
            }
        }

        // Sort by position
        allMatches.Sort((x, y) => x.Position.CompareTo(y.Position));

        // Remove overlapping matches (prioritize longer matches)
        var validMatches = new List<MatchInfo>();

        foreach (var match in allMatches)
        {
            bool overlaps = false;
            foreach (var existing in validMatches)
            {
                // Check if this match overlaps with an existing match
                if (match.Position < existing.Position + existing.Length &&
                    match.Position + match.Length > existing.Position)
                {
                    overlaps = true;
                    break;
                }
            }

            if (!overlaps)
            {
                validMatches.Add(match);
            }
        }

        return validMatches;
    }

    private bool IsExactMatch(string text, string searchString, int index)
    {
        // For alphanumeric strings (words), check word boundaries
        if (searchString.Any(c => char.IsLetterOrDigit(c)))
        {
            // Check character before the match
            if (index > 0)
            {
                char charBefore = text[index - 1];
                if (char.IsLetterOrDigit(charBefore) || charBefore == '_')
                {
                    return false;
                }
            }

            // Check character after the match
            if (index + searchString.Length < text.Length)
            {
                char charAfter = text[index + searchString.Length];
                if (char.IsLetterOrDigit(charAfter) || charAfter == '_')
                {
                    return false;
                }
            }
        }
        else
        {
            // For symbol-only strings, check that they're not part of longer symbol sequences
            // Check character before the match
            if (index > 0)
            {
                char charBefore = text[index - 1];
                // If the character before is the same type of symbol, it's not an exact match
                if (!char.IsWhiteSpace(charBefore) && !char.IsLetterOrDigit(charBefore))
                {
                    return false;
                }
            }

            // Check character after the match
            if (index + searchString.Length < text.Length)
            {
                char charAfter = text[index + searchString.Length];
                // If the character after is the same type of symbol, it's not an exact match
                if (!char.IsWhiteSpace(charAfter) && !char.IsLetterOrDigit(charAfter))
                {
                    return false;
                }
            }
        }

        return true;
    }

    // Helper class for match information
    private class MatchInfo
    {
        public string SearchString { get; set; }
        public int Position { get; set; }
        public int Length { get; set; }
    }
}

/// <summary>
/// Represents a match with its surrounding context
/// </summary>
public class MatchContext
{
    public string SearchString { get; set; }
    public string MatchedText { get; set; }
    public int Position { get; set; }
    public string BeforeContext { get; set; }
    public string AfterContext { get; set; }
    public string FullContext { get; set; }
}