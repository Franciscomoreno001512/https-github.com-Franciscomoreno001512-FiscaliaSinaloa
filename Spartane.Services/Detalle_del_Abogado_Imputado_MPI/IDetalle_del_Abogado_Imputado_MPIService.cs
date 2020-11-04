using System;
using Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_del_Abogado_Imputado_MPI
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_del_Abogado_Imputado_MPIService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI.Detalle_del_Abogado_Imputado_MPI> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
