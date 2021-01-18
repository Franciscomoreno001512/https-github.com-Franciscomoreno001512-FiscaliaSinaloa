using System;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Consulta_de_Mandamientos_Judiciales
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IConsulta_de_Mandamientos_JudicialesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
