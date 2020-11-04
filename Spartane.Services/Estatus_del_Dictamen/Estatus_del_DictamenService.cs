using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_del_Dictamen
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_del_DictamenService : IEstatus_del_DictamenService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> _Estatus_del_DictamenRepository;
        #endregion

        #region Ctor
        public Estatus_del_DictamenService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> Estatus_del_DictamenRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_del_DictamenRepository = Estatus_del_DictamenRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> SelAll(bool ConRelaciones)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_DictamenPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_del_DictamenPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_del_DictamenRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_del_DictamenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen entity, Spartane.Core.Domain.User.GlobalData Estatus_del_DictamenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen entity, Spartane.Core.Domain.User.GlobalData Estatus_del_DictamenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

