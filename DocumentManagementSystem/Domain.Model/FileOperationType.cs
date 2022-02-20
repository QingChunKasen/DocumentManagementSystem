namespace Domain
{
    public enum FileOperationType
    {
        None = 0,
        ExtentionChange = 1,
        AddPrefix = 2,
        AddSubfix = 3,
        Removecharactersbeginning = 4,
        RemoveCharactersEnd = 5,
        RemoveMatchingBeginning = 6,
        RemoveMatchingEnd = 7,
        RemoveDoubleSpaces = 8,
        RemoveSpecifiedCharacters = 9,
        ReplaceWith = 10,
        ConvertToLowercase = 11,
        ConvertToUpercase = 12,
        AppendFolderName = 13,
        AppendDate = 14
    }
}
