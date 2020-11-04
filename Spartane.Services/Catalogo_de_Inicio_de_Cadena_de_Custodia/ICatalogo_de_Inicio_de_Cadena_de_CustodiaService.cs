using System;
using Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Catalogo_de_Inicio_de_Cadena_de_Custodia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICatalogo_de_Inicio_de_Cadena_de_CustodiaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
