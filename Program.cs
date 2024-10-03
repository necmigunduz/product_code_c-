
string sku = "03-MN-L";

string[] product = sku.Split("-");

string type = "";
string color = "";
string size = "";

// if (product[0] == "01") type = "Sweat shirt";
// if (product[0] == "02") type = "T-Shirt";
// if (product[0] == "03") type = "Sweat pants";
// if (product[0] != "01" && product[0] != "02" && product[0] != "03") type = "Other type";

// if (product[1] == "BL") color = "Black";
// if (product[1] == "MN") color = "Maroon";
// if (product[1] != "BL" && product[1] != "MN") color = "Other color";

// if (product[2] == "S") size = "Small";
// if (product[2] == "M") size = "Medium";
// if (product[2] == "L") size = "Large";
// if (product[2] != "S" && product[2] != "M" && product[2] != "L") size = "Other size";

type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-Shirt",
    "03" => "Sweat pants",
    _ => "Other type",
};

color = product[1] switch
{
    "BL" => "Black",
    "MN" => "Maroon",
    _ => "Other color",
};

size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "Other size",
};

Console.WriteLine($"Product Info\nType:\t\tColor:\t\tSize:\n{type}\t{color}\t\t{size}");