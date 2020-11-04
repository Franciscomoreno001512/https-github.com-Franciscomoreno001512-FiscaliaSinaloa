using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Ojos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Ojos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class OjosService : IOjosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Ojos.Ojos> _OjosRepository;
        #endregion

        #region Ctor
        public OjosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Ojos.Ojos> OjosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._OjosRepository = OjosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(bool ConRelaciones)
        {
            return this._OjosRepository.Table.ToList();
        }

        public IList<Core.Domain.Ojos.Ojos> SelAllComplete(bool ConRelaciones)
        {
            return this._OjosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._OjosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ojos.Ojos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ojos.OjosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            OjosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Ojos.Ojos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._OjosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ojos.Ojos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Ojos.Ojos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Ojos.Ojos entity, Spartane.Core.Domain.User.GlobalData OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Ojos.Ojos entity, Spartane.Core.Domain.User.GlobalData OjosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

