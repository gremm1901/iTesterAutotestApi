﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTesterAutotestApi.Helpers
{
    /// <summary>
    /// Класс в котором собраны вспомогательные функции
    /// </summary>
    public static class AssertionHelper
    {

        /// <summary>
        /// Возвращает булевое значение при проверки статуса
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        /// <returns></returns>
        public static bool CheckStatusBool(RestResponse requst, int status = 200)
        {
            return (int)requst.StatusCode == status;
        }
        /// <summary>
        /// Проверяет статус
        /// </summary>
        /// <param name="requst">Реквест</param>
        /// <param name="status">Статуст который мы ожидаем</param>
        public static void ChecksStatus(RestResponse requst, int status = 200)
        {
            Assert.IsTrue(CheckStatusBool(requst, status), $"Статус код {(int)requst.StatusCode} не соответствует {status}");
        }
    }
}
