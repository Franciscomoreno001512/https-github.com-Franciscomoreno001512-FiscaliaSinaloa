using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Calvicie;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Calvicie
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CalvicieService : ICalvicieService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Calvicie.Calvicie> _CalvicieRepository;
        #endregion

        #region Ctor
        public CalvicieService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Calvicie.Calvicie> CalvicieRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CalvicieRepository = CalvicieRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(bool ConRelaciones)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public IList<Core.Domain.Calvicie.Calvicie> SelAllComplete(bool ConRelaciones)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Calvicie.Calvicie> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calvicie.CalviciePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CalviciePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Calvicie.Calvicie> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CalvicieRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Calvicie.Calvicie GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Calvicie.Calvicie result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CalvicieInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Calvicie.Calvicie entity, Spartane.Core.Domain.User.GlobalData CalvicieInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Calvicie.Calvicie entity, Spartane.Core.Domain.User.GlobalData CalvicieInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

