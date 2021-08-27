using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.UI.Common
{
    public abstract partial class SingleObjectViewModel<TEntity, TPrimaryKey, TUnitOfWork> : SingleObjectViewModelBase<TEntity, TPrimaryKey, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : IUnitOfWork
    {
        protected override void OnBeforeEntitySaved(TPrimaryKey primaryKey, TEntity entity, bool isNewEntity)
        {
            base.OnBeforeEntitySaved(primaryKey, entity, isNewEntity);
            if (isNewEntity)
            {
                SetAuditablePropertiesForCreate(entity);
            }
            else
            {
                SetAuditablePropertiesForModify(entity);
            }
        }

        void SetAuditablePropertiesForCreate(object obj)
        {
            SetTimeForObject(obj, "CreatedAt", DateTime.Now);
            SetPersonForObject(obj, "CreatedBy", "admin");
        }
        void SetAuditablePropertiesForModify(object obj)
        {
            SetTimeForObject(obj, "ModifiedAt", DateTime.Now);
            SetPersonForObject(obj, "ModifiedBy", "admin");
        }
        void SetTimeForObject(object obj, string propName, DateTime dateTime)
        {
            PropertyInfo propInfo = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
            if (propInfo != null)
            {
                propInfo.SetValue(obj, dateTime);
            }
        }
        void SetPersonForObject(object obj, string propName, string personName)
        {
            PropertyInfo propInfo = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .FirstOrDefault(x => x.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
            if (propInfo != null)
            {
                propInfo.SetValue(obj, personName);
            }
        }
    }
}
