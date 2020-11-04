using System;
using Spartane.Core.Domain.Circunstancias;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Circunstancias
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICircunstanciasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Circunstancias.Circunstancias GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Circunstancias.Circunstancias entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Circunstancias.Circunstancias entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Circunstancias.CircunstanciasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Circunstancias.Circunstancias> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
