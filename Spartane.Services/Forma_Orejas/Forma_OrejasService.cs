using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Forma_Orejas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Forma_Orejas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Forma_OrejasService : IForma_OrejasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> _Forma_OrejasRepository;
        #endregion

        #region Ctor
        public Forma_OrejasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> Forma_OrejasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Forma_OrejasRepository = Forma_OrejasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(bool ConRelaciones)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public IList<Core.Domain.Forma_Orejas.Forma_Orejas> SelAllComplete(bool ConRelaciones)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Orejas.Forma_OrejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Forma_OrejasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Forma_OrejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Orejas.Forma_Orejas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Forma_Orejas.Forma_Orejas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Forma_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Forma_Orejas.Forma_Orejas entity, Spartane.Core.Domain.User.GlobalData Forma_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Forma_Orejas.Forma_Orejas entity, Spartane.Core.Domain.User.GlobalData Forma_OrejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

