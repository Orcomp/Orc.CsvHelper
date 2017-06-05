// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICsvReaderService.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Csv
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading.Tasks;
    using CsvHelper;
    using CsvHelper.Configuration;

    public interface ICsvReaderService
    {
        #region Methods
        Task<IList<T>> ReadCsvAsync<T>(string csvFilePath, CsvClassMap csvMap, Action<T> initializer = null, CsvConfiguration csvConfiguration = null, bool throwOnError = true, CultureInfo culture = null);

        IEnumerable<T> ReadCsv<T>(string csvFilePath, CsvClassMap csvMap, Action<T> initializer = null, CsvConfiguration csvConfiguration = null, bool throwOnError = true, CultureInfo culture = null);

        CsvReader CreateReader(string csvFilePath, CsvClassMap csvMap, CsvConfiguration csvConfiguration = null, CultureInfo culture = null);

        [ObsoleteEx(RemoveInVersion = "2.0", TreatAsErrorFromVersion = "1.1", Message = "use ICsvReaderServiceExtensions")]
        IEnumerable<T> ReadCsv<T, TMap>(string csvFilePath, Action<T> initializer = null, CsvConfiguration csvConfiguration = null, bool throwOnError = true)
            where TMap : CsvClassMap;

        [ObsoleteEx(RemoveInVersion = "2.0", TreatAsErrorFromVersion = "1.1", Message = "use ICsvReaderServiceExtensions")]
        IEnumerable<T> ReadCsv<T>(string csvFilePath, Action<T> initializer = null, Type mapType = null, CsvConfiguration csvConfiguration = null, bool throwOnError = true, CultureInfo culture = null);

        [ObsoleteEx(RemoveInVersion = "2.0", TreatAsErrorFromVersion = "1.1", Message = "use ICsvReaderServiceExtensions")]
        CsvReader CreateReader(string csvFilePath, Type csvMapType = null, CsvConfiguration csvConfiguration = null, CultureInfo culture = null);
        #endregion
    }
}