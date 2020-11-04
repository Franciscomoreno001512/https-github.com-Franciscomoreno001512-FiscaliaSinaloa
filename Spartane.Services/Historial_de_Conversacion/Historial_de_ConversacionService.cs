using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Historial_de_Conversacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Historial_de_Conversacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Historial_de_ConversacionService : IHistorial_de_ConversacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> _Historial_de_ConversacionRepository;
        #endregion

        #region Ctor
        public Historial_de_ConversacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> Historial_de_ConversacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Historial_de_ConversacionRepository = Historial_de_ConversacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(bool ConRelaciones)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_ConversacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Historial_de_ConversacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Historial_de_ConversacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

