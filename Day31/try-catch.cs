try {
    int x = 10/0;
} catch(Exception ex) {
    Console.WriteLine("Error: " + ex.Message);
}
