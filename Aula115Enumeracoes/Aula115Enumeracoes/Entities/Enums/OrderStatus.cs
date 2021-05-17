namespace Aula115Enumeracoes.Entities.Enums
{
    enum OrderStatus : int
    {
        // Caso não seja atribuído nenhum valor, o C# faz uma contagem começando com o valor 0 (zero).
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
