using iTesterAutotestApi.Entities.Requests;
using iTesterAutotestApi.Entities.Responses;
using RestSharp;

namespace iTesterAutotestApi.Client
{
    /// <summary>
    /// Класс с методами свагера iTester
    /// </summary>
    public class ITesterClient
    {
        RestClient _client;
        public ITesterClient(string url)
        {
            _client = new RestClient(url);
        }

        //Методы по счетам
        /// <summary>
        /// Возвращает список счетов клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse<List<ScoreResponse>> GetScores()
        {
            var request = new RestRequest("/api/accounts", Method.Get);
            return _client.Execute<List<ScoreResponse>>(request);
        }
        /// <summary>
        /// Возвращает счет по его id
        /// </summary>
        /// <param name="id">id счета</param>
        /// <returns></returns>
        public RestResponse<ScoreResponse> GetScoreId(int id)
        {
            var request = new RestRequest($"/api/accounts/{id}", Method.Get);
            return _client.Execute<ScoreResponse>(request);
        }
        /// <summary>
        /// Обновляет информацию о счете
        /// </summary>
        /// <param name="body">новые данные по счету</param>
        /// <returns></returns>
        public RestResponse<ScoreResponse> PatchScore(ScoreRequest body)
        {
            var request = new RestRequest("/api/accounts", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute<ScoreResponse>(request);
        }
        /// <summary>
        /// Блокирует счет по его id
        /// </summary>
        /// <param name="id">id счета для блокировки</param>
        /// <returns></returns>
        public RestResponse<ScoreResponse> PatchLockScoreId(int id)
        {
            var request = new RestRequest($"/api/accounts/lock/{id}", Method.Patch);
            return _client.Execute<ScoreResponse>(request);
        }
        /// <summary>
        /// Разблокировывает счет по его id
        /// </summary>
        /// <param name="id">id счета</param>
        /// <returns></returns>
        public RestResponse<ScoreResponse> PatchUnlockScoreId(int id)
        {
            var request = new RestRequest($"/api/accounts/unlock/{id}", Method.Patch);
            return _client.Execute<ScoreResponse>(request);
        }

        //Методы по авторизации
        /// <summary>
        /// Авторизация клиента
        /// </summary>
        /// <param name="body">Данные клиента для входа</param>
        public RestResponse<AuthResponse> AuthClient(AuthRequest body)
        {
            var request = new RestRequest("api/authorization/token", Method.Post);
            request.AddJsonBody(body);
            _client.AddDefaultHeader("Authorization", "Bearer " + _client.Execute<AuthResponse>(request).Data.AccessToken);
            return _client.Execute<AuthResponse>(request);
        }
        /// <summary>
        /// Метод по обновлению токена
        /// </summary>
        /// <param name="body">Тело с токеном и токеном для обновления</param>
        /// <returns></returns>
        public RestResponse<AuthResponse> RefreshTokenClient(TokenRefreshRequest body)
        {
            var request = new RestRequest("api/authorization/token", Method.Post);
            request.AddJsonBody(body);
            _client.AddDefaultHeader("Authorization", "Bearer " + _client.Execute<AuthResponse>(request).Data.AccessToken);
            return _client.Execute<AuthResponse>(request);
        }
        /// <summary>
        /// Сбрасывет пароль на "111111"
        /// Как реализовать если нет ключа, поэтому оставил так
        /// </summary>
        /// <param name="body">Логин клиента</param>
        /// <returns></returns>
        public RestResponse PasswordReset(LoginRequest body)
        {
            var request = new RestRequest("/api/authorization/restore", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }
        /// <summary>
        /// Метод для разлогинивания
        /// </summary>
        /// <returns></returns>
        public RestResponse LogoutClient()
        {
            var request = new RestRequest("/api/authorization/logout", Method.Delete);
            return _client.Execute(request);
        }

        //Методы по картам
        /// <summary>
        /// Возвращает список карт клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse<List<CardResponse>> GetCards()
        {
            var request = new RestRequest("/api/cards", Method.Get);
            return _client.Execute<List<CardResponse>>(request);
        }
        /// <summary>
        /// Возвращает CVC карты по ее ID
        /// </summary>
        /// <param name="id">Id карты</param>
        /// <returns></returns>
        public RestResponse GetCVCCard(int id)
        {
            var request = new RestRequest($"/api/cards/{id}/cvc", Method.Get);
            return _client.Execute(request);
        }
        /// <summary>
        /// Возвращает список заказов карт клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse<List<OrdersCardResponse>> GetOrderCards()
        {
            var request = new RestRequest($"/api/cards/orders", Method.Get);
            return _client.Execute<List<OrdersCardResponse>>(request);
        }
        /// <summary>
        /// Активирует карту по ее id и с помощью пинкода
        /// </summary>
        /// <param name="id">Id карты</param>
        /// <param name="body">Пинкод карты</param>
        /// <returns></returns>
        public RestResponse<ActivateCardResponse> ActivateCard(int id, PinCodeRequest body)
        {
            var request = new RestRequest($"/api/cards/activate/{id}", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute<ActivateCardResponse>(request);
        }
        /// <summary>
        /// Блокирует карту по ее ID
        /// </summary>
        /// <param name="id">Id карты</param>
        /// <returns></returns>
        public RestResponse<ActivateCardResponse> BlockCard(int id)
        {
            var request = new RestRequest($"/api/cards/lock/{id}", Method.Patch);
            return _client.Execute<ActivateCardResponse>(request);
        }
        /// <summary>
        /// Разблокирует карту по ее ID
        /// </summary>
        /// <param name="id">Id карты</param>
        /// <returns></returns>
        public RestResponse<CardResponse> UnlockCard(int id)
        {
            var request = new RestRequest($"/api/cards/unlock/{id}", Method.Patch);
            return _client.Execute<CardResponse>(request);
        }

        //Методы по клиенту
        /// <summary>
        /// Создает клиента
        /// </summary>
        /// <param name="body">Данные клиента</param>
        /// <returns></returns>
        public RestResponse CreateClient(CreateClientRequest body)
        {
            var request = new RestRequest("/api/clients", Method.Put);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }
        /// <summary>
        /// Возращает данные по клиенту
        /// </summary>
        /// <returns></returns>
        public RestResponse<CreateClientResponse> GetClient()
        {
            var request = new RestRequest("/api/clients", Method.Get);
            return _client.Execute<CreateClientResponse>(request);
        }
        /// <summary>
        /// Обновляет данные по клиенту
        /// </summary>
        /// <param name="body">Новые данные клиента</param>
        /// <returns></returns>
        public RestResponse PatchClient(CreateClientRequest body)
        {
            var request = new RestRequest("/api/clients", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }
        /// <summary>
        /// Удаляет клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse DeleteClient()
        {
            var request = new RestRequest("/api/clients", Method.Delete);
            return _client.Execute(request);
        }
        /// <summary>
        /// Обновляет пароль клиента
        /// </summary>
        /// <param name="body">Новый пароль клиента</param>
        /// <returns></returns>
        public RestResponse PatchPasswordClient(PasswordRequests body)
        {
            var request = new RestRequest("/api/clients/password", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }

        //Методы по операциям
        /// <summary>
        /// Запускает новую операцию
        /// </summary>
        /// <param name="body">Номер операцииAccountOpen = 1000,AccountRefill = 1001,AccountTransfer = 1002,CardOrder = 2000</param>
        /// <returns></returns>
        public RestResponse<OperationResponse> StartOperation(CodeOperationRequest body)
        {
            var request = new RestRequest("/api/operations", Method.Put);
            request.AddJsonBody(body);
            return _client.Execute<OperationResponse>(request);
        }
        /// <summary>
        /// Шаг с подтверждение операции
        /// </summary>
        /// <param name="body">Данные по операции</param>
        /// <param name="id">Номер операции</param>
        /// <returns></returns>
        public RestResponse<NextStepResponse> NextStepOperation(NextStepRequest body, int id)
        {
            var request = new RestRequest($"/api/operations?requestId={id}", Method.Patch);
            request.AddJsonBody(body);
            return _client.Execute<NextStepResponse>(request);
        }
        /// <summary>
        /// Финальный шаг операции
        /// </summary>
        /// <param name="id">номер операции</param>
        /// <returns></returns>
        public RestResponse<NextStepResponse> ConfrimOperation(int id)
        {
            var request = new RestRequest($"/api/operations?requestId={id}", Method.Post);
            return _client.Execute<NextStepResponse>(request);
        }
        /// <summary>
        /// Удаляет операцию по ее Id
        /// </summary>
        /// <param name="id">Id операции</param>
        /// <returns></returns>
        public RestResponse DeleteOperation(int id)
        {
            var request = new RestRequest($"/api/operations?requestId={id}", Method.Delete);
            return _client.Execute(request);
        }
        /// <summary>
        /// Получить список операций клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse<NextStepResponse> GetOperationClient()
        {
            var request = new RestRequest("/api/operations", Method.Get);
            return _client.Execute<NextStepResponse>(request);
        }

        //Методы по доступным продуктам
        /// <summary>
        /// Список доступных продуктов для клиента
        /// </summary>
        /// <returns></returns>
        public RestResponse<List<ProductsResponse>> GetProductsClient()
        {
            var request = new RestRequest("/api/showcase/products", Method.Get);
            return _client.Execute<List<ProductsResponse>>(request);
        }
        /// <summary>
        /// Возвращает продукт по его ID
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <returns></returns>
        public RestResponse<ProductsResponse> GetProductIdClient(int id)
        {
            var request = new RestRequest($"/api/showcase/products/{id}", Method.Get);
            return _client.Execute<ProductsResponse>(request);
        }

        //Методы по транзакциям
        /// <summary>
        /// Возвращает список транзакций по всем счетам
        /// </summary>
        /// <returns></returns>
        public RestResponse<List<TransactionsResponse>> GetTransactions()
        {
            var request = new RestRequest("/api/transactions", Method.Get);
            return _client.Execute<List<TransactionsResponse>>(request);
        }
        /// <summary>
        /// Возвращает список транзакций по счету
        /// </summary>
        /// <param name="id">Номер счета</param>
        /// <returns></returns>
        public RestResponse<List<TransactionsResponse>> GetTransactionsScore(int id)
        {
            var request = new RestRequest($"/api/transactions/byAccount/{id}", Method.Get);
            return _client.Execute<List<TransactionsResponse>>(request);
        }
        /// <summary>
        /// Возвращает транзакцию по ее ID
        /// </summary>
        /// <param name="id">Id транзакции</param>
        /// <returns></returns>
        public RestResponse<TransactionsResponse> GetTransactionsID(int id)
        {
            var request = new RestRequest($"/api/transactions/info/{id}", Method.Get);
            return _client.Execute<TransactionsResponse>(request);
        }
    }
}
