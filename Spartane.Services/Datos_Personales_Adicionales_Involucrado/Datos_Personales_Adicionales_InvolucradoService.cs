using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Datos_Personales_Adicionales_Involucrado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Datos_Personales_Adicionales_InvolucradoService : IDatos_Personales_Adicionales_InvolucradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> _Datos_Personales_Adicionales_InvolucradoRepository;
        #endregion

        #region Ctor
        public Datos_Personales_Adicionales_InvolucradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> Datos_Personales_Adicionales_InvolucradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Datos_Personales_Adicionales_InvolucradoRepository = Datos_Personales_Adicionales_InvolucradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(bool ConRelaciones)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAllComplete(bool ConRelaciones)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Datos_Personales_Adicionales_InvolucradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Datos_Personales_Adicionales_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Spartane.Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

