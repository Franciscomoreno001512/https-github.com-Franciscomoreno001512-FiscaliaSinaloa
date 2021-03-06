﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Lugar_del_Hallazgo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Lugar_del_Hallazgo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Lugar_del_HallazgoService : ILugar_del_HallazgoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> _Lugar_del_HallazgoRepository;
        #endregion

        #region Ctor
        public Lugar_del_HallazgoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> Lugar_del_HallazgoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Lugar_del_HallazgoRepository = Lugar_del_HallazgoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(bool ConRelaciones)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAllComplete(bool ConRelaciones)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Lugar_del_HallazgoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Lugar_del_HallazgoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Spartane.Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

