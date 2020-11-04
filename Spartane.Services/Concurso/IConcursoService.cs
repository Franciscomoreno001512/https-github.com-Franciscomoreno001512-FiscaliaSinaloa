using System;
using Spartane.Core.Domain.Concurso;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Concurso
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IConcursoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Concurso.Concurso> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Concurso.Concurso GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Concurso.Concurso entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Concurso.Concurso entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Concurso.Concurso> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Concurso.ConcursoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Concurso.Concurso> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
