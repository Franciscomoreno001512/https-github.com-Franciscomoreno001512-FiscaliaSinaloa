using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Requeridos_que_no_Asisten;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Requeridos_que_no_Asisten
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Requeridos_que_no_AsistenService : IRequeridos_que_no_AsistenService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> _Requeridos_que_no_AsistenRepository;
        #endregion

        #region Ctor
        public Requeridos_que_no_AsistenService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> Requeridos_que_no_AsistenRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Requeridos_que_no_AsistenRepository = Requeridos_que_no_AsistenRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(bool ConRelaciones)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAllComplete(bool ConRelaciones)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Requeridos_que_no_AsistenPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Requeridos_que_no_AsistenRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Spartane.Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

