using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using Recipizer.Core.Model;

namespace Recipizer.Core.ViewModels
{
    public class CreateRecipeViewModel : MvxViewModel
    {
        List<Ingredient> ingredients;
        public CreateRecipeViewModel()
        {
            
        }

        public void OnClickedAddIngredients(string name, string amount, string Unit)
        {
            Ingredient ingredient = new Ingredient(name, amount,
                Ingredient.StringToUnit(Unit));
            ingredients.Add(ingredient);
            ingredientAdapter.NotifyDataSetChanged();

            //name = "";
            //amount = "";
            //spinnerUnits.SetSelection(0);
        }
    }
}
