using System;
using Spartane.Core.Domain.Idioma;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Idioma
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IIdiomaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Idioma.Idioma> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Idioma.Idioma GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Idioma.Idioma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Idioma.Idioma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Idioma.Idioma> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Idioma.Idioma> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Idioma.IdiomaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Idioma.Idioma> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
