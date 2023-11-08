using KalenderTurizm.WebUI.BasketTransaction.BasketModels;

namespace KalenderTurizm.WebUI.BasketTransaction
{
    public interface IBasketTransaction
    {
        BasketDto GetOrCreateBasket();
        void SaveUpdateBasketItem(BasketItemDto basketItem);
        void RemoveOrDecrease(int placeToVisitId);
        void DeleteItem(int placeToVisitId);
        void DeleteBasket();
    }
}
