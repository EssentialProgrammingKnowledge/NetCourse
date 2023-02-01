using System.Text.Json;

dynamic variable = "String";
Console.WriteLine(variable);
variable = 20;
Console.WriteLine(variable);
variable = "dynamic";
Console.WriteLine(variable);
variable = new
{
    A = 1000
};
Console.WriteLine(variable);
variable = new Dynamics.OldVersion.Mechanic();
Console.WriteLine(ConvertToNewEmployee(variable));

static Dynamics.NewVersion.Employee? ConvertToNewEmployee(Dynamics.OldVersion.Employee employee)
{
    if (employee == null)
        return null;

    if (employee is Dynamics.OldVersion.Mechanic mechanic)
        return Convert<Dynamics.NewVersion.Mechanic, Dynamics.OldVersion.Mechanic>(mechanic);

    if (employee is Dynamics.OldVersion.Architect architect)
        return Convert<Dynamics.NewVersion.Architect, Dynamics.OldVersion.Architect>(architect);

    throw new ArgumentException($"Unknown Employee {nameof(employee)}");
}

static T? Convert<T, U>(U a)
    where T : class, new()
    where U : class, new()
{
    return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(a));
}