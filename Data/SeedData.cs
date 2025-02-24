namespace RestaurantPOS.Data;

public static class SeedData
{
    public static List<MenuCategory> GetMenuCategories()
    {
        return new List<MenuCategory>
        {
            new MenuCategory { Id = 1, Name = "Bebidas", Icon = "drink.png" },
            new MenuCategory { Id = 2, Name = "Prato Principal", Icon = "meal.png" },
            new MenuCategory { Id = 3, Name = "Lanches", Icon = "snacks.png" },
            new MenuCategory { Id = 4, Name = "Sobremesas", Icon = "cake.png" },
            new MenuCategory { Id = 5, Name = "Comida Rápida", Icon = "fast_food.png" }
        };
    }

    public static List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Cerveja", Icon = "beer.png", Description = "Cerveja gelada", Price = 4.99m },
            new MenuItem { Id = 2, Name = "Biryani", Icon = "biryani.png", Description = "Biryani de frango picante", Price = 7.99m },
            new MenuItem { Id = 3, Name = "Pãezinhos", Icon = "buns.png", Description = "Pãezinhos recém-assados", Price = 2.99m },
            new MenuItem { Id = 4, Name = "Combo de Hambúrguer e Batata Frita", Icon = "burger_fries_combo.png", Description = "Hambúrguer com batata frita", Price = 5.99m },
            new MenuItem { Id = 5, Name = "Bolo", Icon = "cake.png", Description = "Delicioso bolo de chocolate", Price = 3.99m },
            new MenuItem { Id = 6, Name = "Chocolate", Icon = "chocolate.png", Description = "Barra de chocolate intensa", Price = 1.99m },
            new MenuItem { Id = 7, Name = "Coquetel", Icon = "cocktail.png", Description = "Coquetel refrescante", Price = 6.99m },
            new MenuItem { Id = 8, Name = "Café", Icon = "coffee.png", Description = "Café quente", Price = 1.99m },
            new MenuItem { Id = 9, Name = "Cupcake", Icon = "cupcake.png", Description = "Cupcake doce", Price = 2.49m },
            new MenuItem { Id = 10, Name = "Donut", Icon = "donut.png", Description = "Donut glaceado", Price = 1.49m },
            new MenuItem { Id = 11, Name = "Bebida Energética", Icon = "energy_drink.png", Description = "Bebida energética", Price = 2.99m },
            new MenuItem { Id = 12, Name = "Comida Rápida", Icon = "fast_food.png", Description = "Comida rápida, prática e saborosa", Price = 5.99m },
            new MenuItem { Id = 13, Name = "Fish and Chips", Icon = "fish_and_chips.png", Description = "Peixe e batatas fritas crocantes", Price = 6.99m },
            new MenuItem { Id = 14, Name = "Peixe", Icon = "fish.png", Description = "Peixe grelhado", Price = 7.99m },
            new MenuItem { Id = 15, Name = "Batata Frita", Icon = "french_fries.png", Description = "Batata frita crocante", Price = 2.99m },
            new MenuItem { Id = 16, Name = "Frango Frito", Icon = "fried_chicken.png", Description = "Frango frito crocante", Price = 5.99m },
            new MenuItem { Id = 17, Name = "Ovo Frito", Icon = "fried_egg.png", Description = "Ovo frito com gema mole", Price = 1.49m },
            new MenuItem { Id = 18, Name = "Arroz Frito", Icon = "fried_rice.png", Description = "Arroz frito saboroso", Price = 4.99m },
            new MenuItem { Id = 19, Name = "Hambúrguer", Icon = "hamburger.png", Description = "Hambúrguer suculento", Price = 4.99m },
            new MenuItem { Id = 20, Name = "Hotdog", Icon = "hotdog.png", Description = "Hotdog grelhado", Price = 3.49m },
            new MenuItem { Id = 21, Name = "Sorvete", Icon = "ice_cream.png", Description = "Sorvete gelado", Price = 2.99m },
            new MenuItem { Id = 22, Name = "Prato de Idlis", Icon = "idli_platter.png", Description = "Prato de idlis do sul da Índia", Price = 3.99m },
            new MenuItem { Id = 23, Name = "Kebab", Icon = "kebab.png", Description = "Kebab grelhado", Price = 5.99m },
            new MenuItem { Id = 24, Name = "Kimchi Jjigae", Icon = "kimchi_jjiage.png", Description = "Ensopado picante de kimchi", Price = 6.99m },
            new MenuItem { Id = 25, Name = "Laddu", Icon = "laddu.png", Description = "Laddu doce", Price = 1.99m },
            new MenuItem { Id = 26, Name = "Lagosta", Icon = "lobster.png", Description = "Lagosta fresca", Price = 15.99m },
            new MenuItem { Id = 27, Name = "Manga", Icon = "mango.png", Description = "Manga madura", Price = 1.49m },
            new MenuItem { Id = 28, Name = "Masala Dosa", Icon = "masala_dosa.png", Description = "Masala dosa crocante", Price = 4.99m },
            new MenuItem { Id = 29, Name = "Refeição", Icon = "meal.png", Description = "Refeição completa", Price = 9.99m },
            new MenuItem { Id = 30, Name = "Nachos", Icon = "nachos.png", Description = "Nachos com queijo", Price = 3.99m },
            new MenuItem { Id = 31, Name = "Noodles", Icon = "noodles.png", Description = "Noodles refogados", Price = 4.99m },
            new MenuItem { Id = 32, Name = "Suco de Laranja", Icon = "orange_juice.png", Description = "Suco de laranja fresco", Price = 2.49m },
            new MenuItem { Id = 33, Name = "Panquecas", Icon = "pancakes.png", Description = "Panquecas fofas", Price = 3.99m },
            new MenuItem { Id = 34, Name = "Paneer", Icon = "paneer.png", Description = "Curry de paneer", Price = 4.99m },
            new MenuItem { Id = 35, Name = "Massa", Icon = "pasta.png", Description = "Massa italiana", Price = 5.99m },
            new MenuItem { Id = 36, Name = "Torta", Icon = "pie.png", Description = "Torta de frutas", Price = 3.99m },
            new MenuItem { Id = 37, Name = "Fatia de Pizza", Icon = "pizza_slice.png", Description = "Fatia de pizza", Price = 2.99m },
            new MenuItem { Id = 38, Name = "Pizza", Icon = "pizza.png", Description = "Pizza inteira", Price = 8.99m },
            new MenuItem { Id = 39, Name = "Ramen", Icon = "ramen.png", Description = "Ramen japonês", Price = 6.99m },
            new MenuItem { Id = 40, Name = "Arroz", Icon = "rice.png", Description = "Arroz cozido no vapor", Price = 1.99m },
            new MenuItem { Id = 41, Name = "Frango Assado", Icon = "roasted_chicken.png", Description = "Frango assado", Price = 7.99m },
            new MenuItem { Id = 42, Name = "Tigela de Salada", Icon = "salad_bowl.png", Description = "Tigela de salada fresca", Price = 4.99m },
            new MenuItem { Id = 43, Name = "Prato de Salada", Icon = "salad_plate.png", Description = "Prato de salada fresca", Price = 4.99m },
            new MenuItem { Id = 44, Name = "Samosa", Icon = "samosa.png", Description = "Samosa crocante", Price = 1.99m },
            new MenuItem { Id = 45, Name = "Sanduíche", Icon = "sandwich.png", Description = "Sanduíche saboroso", Price = 3.99m },
            new MenuItem { Id = 46, Name = "Lanches", Icon = "snacks.png", Description = "Vários lanches", Price = 2.99m },
            new MenuItem { Id = 47, Name = "Refrigerante", Icon = "soda.png", Description = "Refrigerante refrescante", Price = 1.49m },
            new MenuItem { Id = 48, Name = "Bebida Refrescante", Icon = "soft_drink.png", Description = "Bebida gelada", Price = 1.99m },
            new MenuItem { Id = 49, Name = "Soju", Icon = "soju.png", Description = "Soju coreano", Price = 3.99m },
            new MenuItem { Id = 50, Name = "Espaguete", Icon = "spaghetti.png", Description = "Espaguete italiano", Price = 5.99m },
            new MenuItem { Id = 51, Name = "Sushi", Icon = "sushi.png", Description = "Sushi sortido", Price = 8.99m },
            new MenuItem { Id = 52, Name = "Taco", Icon = "taco.png", Description = "Taco mexicano", Price = 3.99m },
            new MenuItem { Id = 53, Name = "Comida Tailandesa", Icon = "thai_food.png", Description = "Comida tailandesa picante", Price = 6.99m },
            new MenuItem { Id = 54, Name = "Thali", Icon = "thali.png", Description = "Thali indiano", Price = 7.99m },
            new MenuItem { Id = 55, Name = "Wrap", Icon = "wrap.png", Description = "Wrap saudável", Price = 4.99m }
        };
    }

    public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
    {
        return new List<MenuItemCategoryMapping>
        {
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 1 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 6 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 7 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 10 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 11 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 32 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 47 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 48 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 49 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 2 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 13 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 14 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 18 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 20 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 22 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 23 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 24 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 26 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 28 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 29 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 31 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 34 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 35 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 39 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 40 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 41 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 50 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 51 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 52 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 53 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 54 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 55 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 3 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 15 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 16 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 17 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 19 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 30 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 5 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 9 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 21 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 25 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 27 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 33 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 36 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 4 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 12 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 37 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 46 }
        };
    }
}