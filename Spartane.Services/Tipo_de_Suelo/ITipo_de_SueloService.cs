using System;
using Spartane.Core.Domain.Tipo_de_Suelo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Suelo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_SueloService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_SueloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
