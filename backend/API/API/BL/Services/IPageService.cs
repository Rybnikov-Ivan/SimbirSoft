using System;

namespace API.Service
{
    /// <summary>
    /// Интерфейс для работы с страницой
    /// </summary>
    public interface IPageService
    {
        /// <summary>
        /// Метод работы со строкой
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        void GetString(string page);
    }
}
