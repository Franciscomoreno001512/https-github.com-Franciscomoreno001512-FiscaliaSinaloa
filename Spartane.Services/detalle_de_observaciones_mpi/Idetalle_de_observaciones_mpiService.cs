using System;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.detalle_de_observaciones_mpi
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface Idetalle_de_observaciones_mpiService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
