﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
namespace Caviar.SharedKernel
{
    public interface ILanguageService
    {
        CultureInfo CurrentCulture { get; }

        JObject Resources { get; }

        event EventHandler<CultureInfo> LanguageChanged;

        void SetLanguage(CultureInfo culture);

        void SetLanguage(string cultureName);

        string this[string name] { get; }

        /// <summary>
        /// 获取支持的语言列表
        /// </summary>
        /// <returns></returns>
        List<(string CultureName, string ResourceName)> GetLanguageList();
    }
}
