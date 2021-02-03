﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Resumen_Denuncia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Resumen_Denuncia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Resumen_DenunciaService : IDetalle_Resumen_DenunciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> _Detalle_Resumen_DenunciaRepository;
        #endregion

        #region Ctor
        public Detalle_Resumen_DenunciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> Detalle_Resumen_DenunciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Resumen_DenunciaRepository = Detalle_Resumen_DenunciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_DenunciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Resumen_DenunciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Resumen_DenunciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Resumen_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia entity, Spartane.Core.Domain.User.GlobalData Detalle_Resumen_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia entity, Spartane.Core.Domain.User.GlobalData Detalle_Resumen_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

