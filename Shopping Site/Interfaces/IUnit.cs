using Shopping_Site.Models;

namespace Shopping_Site.Interfaces
{
    public interface IUnit
    {
        List<Unit> GetItems(string SortProperty, SortOrder sortOrder);//read All
        Unit GetUnit(int id);// read particular item

        Unit Create(Unit unit);

        Unit Edit(Unit unit);

        Unit Delete(Unit unit);

    }
}
