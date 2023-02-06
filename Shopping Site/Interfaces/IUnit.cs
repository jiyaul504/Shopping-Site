using Shopping_Site.Models;

namespace Shopping_Site.Interfaces
{
    public interface IUnit
    {
        List<Unit> GetItems();
        Unit GetUnit(int id);

        Unit Create(Unit unit);

        Unit Edit(Unit unit);

        Unit Delete(Unit unit);

    }
}
