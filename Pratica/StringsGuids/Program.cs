using System;

namespace StringsGuids
{
    class Program
    {
        static void Main(string[] args)

        {
            // criando um GUID c/ ID novo
            var id = Guid.NewGuid();
            Console.WriteLine(id);
            // GUID c/ 32 caracteres - 55df3a88-9b08-413c-a2c2-5cd56c87fb28

            // O valor do GUID é apresentado pelos 8 primeiros digitos.
            Console.WriteLine(id.ToString().Substring(0, 8)); // 97889f31
        }   // GUID c/ 8 caracteres - 55df3a88
    }
}

// GUID (Globally Unique IDentifier ) - Representa um IDentificador Global Exclusivo.
// Método Guid.ToString -> O valor do GUID é representado como uma série de dígitos (32 digitos) hexadecimais em letras minúsculas. 
// Ex de GUID: 382c74c3-721d-4f34-80e5-57657b6cbc27
// pt-br | https://docs.microsoft.com/pt-br/dotnet/api/system.guid.tostring?view=net-5.0
// en-us | https://docs.microsoft.com/en-us/dotnet/api/system.guid.tostring?view=net-5.0#System_Guid_ToString
