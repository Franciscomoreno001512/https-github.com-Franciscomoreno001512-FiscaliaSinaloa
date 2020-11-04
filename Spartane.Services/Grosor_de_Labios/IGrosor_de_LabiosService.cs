using System;
using Spartane.Core.Domain.Grosor_de_Labios;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Grosor_de_Labios
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGrosor_de_LabiosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_LabiosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
