using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Nariz_Base;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Nariz_Base
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Nariz_BaseService : INariz_BaseService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Nariz_Base.Nariz_Base> _Nariz_BaseRepository;
        #endregion

        #region Ctor
        public Nariz_BaseService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Nariz_Base.Nariz_Base> Nariz_BaseRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Nariz_BaseRepository = Nariz_BaseRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(bool ConRelaciones)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public IList<Core.Domain.Nariz_Base.Nariz_Base> SelAllComplete(bool ConRelaciones)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nariz_Base.Nariz_BasePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Nariz_BasePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Nariz_BaseRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Nariz_Base.Nariz_Base GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Nariz_Base.Nariz_Base result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Nariz_BaseInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Nariz_Base.Nariz_Base entity, Spartane.Core.Domain.User.GlobalData Nariz_BaseInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Nariz_Base.Nariz_Base entity, Spartane.Core.Domain.User.GlobalData Nariz_BaseInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

