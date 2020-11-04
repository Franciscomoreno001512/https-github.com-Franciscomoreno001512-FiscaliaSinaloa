using System;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Spartan_Record_Detail_Management
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISpartan_Record_Detail_ManagementService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
