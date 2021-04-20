using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Ente_que_localiza;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Ente_que_localiza
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Ente_que_localizaService : IEnte_que_localizaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> _Ente_que_localizaRepository;
        #endregion

        #region Ctor
        public Ente_que_localizaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> Ente_que_localizaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Ente_que_localizaRepository = Ente_que_localizaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(bool ConRelaciones)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public IList<Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAllComplete(bool ConRelaciones)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ente_que_localiza.Ente_que_localizaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Ente_que_localizaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Ente_que_localizaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

