using System;
using Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Contestacion_de_Portal_Ciudadano
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IContestacion_de_Portal_CiudadanoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
