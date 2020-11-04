using System;
using Spartane.Core.Domain.Genero;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Genero
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGeneroService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Genero.Genero> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Genero.Genero> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Genero.Genero> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Genero.Genero GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Genero.Genero entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Genero.Genero entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Genero.Genero> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Genero.Genero> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Genero.GeneroPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Genero.Genero> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
