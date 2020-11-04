using System;
using Spartane.Core.Domain.Calidad_Migratoria;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Calidad_Migratoria
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICalidad_MigratoriaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Calidad_Migratoria.Calidad_MigratoriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
