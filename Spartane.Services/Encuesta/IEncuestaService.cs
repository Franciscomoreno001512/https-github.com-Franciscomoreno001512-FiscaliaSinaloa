using System;
using Spartane.Core.Domain.Encuesta;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Encuesta
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEncuestaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Encuesta.Encuesta> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Encuesta.Encuesta> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Encuesta.Encuesta> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Encuesta.Encuesta GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Encuesta.Encuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Encuesta.Encuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Encuesta.Encuesta> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Encuesta.Encuesta> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Encuesta.EncuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Encuesta.Encuesta> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
