using System;
using Spartane.Core.Domain.estatus_mpi;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.estatus_mpi
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface Iestatus_mpiService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.estatus_mpi.estatus_mpi GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.estatus_mpi.estatus_mpi entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.estatus_mpi.estatus_mpiPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.estatus_mpi.estatus_mpi> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
