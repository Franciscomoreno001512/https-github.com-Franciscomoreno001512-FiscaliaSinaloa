using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Catalogo_Tipo_de_Cargo_CC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Catalogo_Tipo_de_Cargo_CCService : ICatalogo_Tipo_de_Cargo_CCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> _Catalogo_Tipo_de_Cargo_CCRepository;
        #endregion

        #region Ctor
        public Catalogo_Tipo_de_Cargo_CCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> Catalogo_Tipo_de_Cargo_CCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Catalogo_Tipo_de_Cargo_CCRepository = Catalogo_Tipo_de_Cargo_CCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(bool ConRelaciones)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public IList<Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAllComplete(bool ConRelaciones)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Catalogo_Tipo_de_Cargo_CCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Catalogo_Tipo_de_Cargo_CCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Tipo_de_Cargo_CCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Tipo_de_Cargo_CCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC.Catalogo_Tipo_de_Cargo_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Tipo_de_Cargo_CCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

