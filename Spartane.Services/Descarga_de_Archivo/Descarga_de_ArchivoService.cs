﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Descarga_de_Archivo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Descarga_de_Archivo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Descarga_de_ArchivoService : IDescarga_de_ArchivoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> _Descarga_de_ArchivoRepository;
        #endregion

        #region Ctor
        public Descarga_de_ArchivoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> Descarga_de_ArchivoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Descarga_de_ArchivoRepository = Descarga_de_ArchivoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(bool ConRelaciones)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public IList<Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAllComplete(bool ConRelaciones)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_ArchivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Descarga_de_ArchivoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Descarga_de_ArchivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Descarga_de_ArchivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo entity, Spartane.Core.Domain.User.GlobalData Descarga_de_ArchivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo entity, Spartane.Core.Domain.User.GlobalData Descarga_de_ArchivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

