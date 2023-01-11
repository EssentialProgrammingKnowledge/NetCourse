static void ThrowException(int id)
{
    if (id == 0)
    {
        throw new ArgumentNullException("id");
    }
}
static void TryCatch()
{
    try
    {
        ThrowException(0);
    }
    catch(Exception exception)
    {
        Console.WriteLine(exception.StackTrace);
        throw;
    }
    finally
    {
        Console.WriteLine("finally");
    }
}

try
{
    TryCatch();
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    Console.WriteLine(exception.StackTrace);
}