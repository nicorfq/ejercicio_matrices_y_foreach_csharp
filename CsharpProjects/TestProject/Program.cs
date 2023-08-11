string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// string[] fraudulentOrderIDs = new string[8];

// fraudulentOrderIDs[0] = "B123";
// fraudulentOrderIDs[1] = "C234";
// fraudulentOrderIDs[2] = "A345";
// fraudulentOrderIDs[3] = "C15";
// fraudulentOrderIDs[4] = "B177";
// fraudulentOrderIDs[5] = "G3003";
// fraudulentOrderIDs[6] = "C235";
// fraudulentOrderIDs[7] = "B179";

foreach (string fraudulentOrderID in fraudulentOrderIDs)
{

  if (fraudulentOrderID.StartsWith("B"))
  {
    Console.WriteLine(fraudulentOrderID);
  }
  
}


