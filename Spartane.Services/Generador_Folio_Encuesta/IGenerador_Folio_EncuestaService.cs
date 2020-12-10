using System;
using Spartane.Core.Domain.Generador_Folio_Encuesta;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Generador_Folio_Encuesta
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGenerador_Folio_EncuestaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_EncuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Generador_Folio_Encuesta.Generador_Folio_Encuesta> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
