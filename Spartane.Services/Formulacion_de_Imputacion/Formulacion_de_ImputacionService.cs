using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Formulacion_de_Imputacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Formulacion_de_Imputacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Formulacion_de_ImputacionService : IFormulacion_de_ImputacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> _Formulacion_de_ImputacionRepository;
        #endregion

        #region Ctor
        public Formulacion_de_ImputacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> Formulacion_de_ImputacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Formulacion_de_ImputacionRepository = Formulacion_de_ImputacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(bool ConRelaciones)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_ImputacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Formulacion_de_ImputacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Formulacion_de_ImputacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion entity, Spartane.Core.Domain.User.GlobalData Formulacion_de_ImputacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

