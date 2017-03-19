(function() {
    $(function() {

        var _tenantService = abp.services.app.tenant;
        var _$modal = $('#TenantCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var tenant = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _tenantService.createTenant(tenant).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new tenant!
            }).always(function() {
                abp.ui.clearBusy(_$modal);
            });
        });
        
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        $('#updateRoleInfo').click(function (e) {

            e.preventDefault();// 阻止表单提交

            //构建要传输的参数对象
            var role = {
                RoleId: 2,
                Name: 'Maxs',
                DisplayName: 'MaxLongs'
            };

            // 动态 api 调用 （直接调用应用层方法）
            //var _roleService = abp.services.app.role;
            //_roleService.updateRoleInfo(role).done(function (data) {
            //    debugger
            //    console.log(data);
            //    location.reload(true); //reload page to see new user!
            //}).always(function () {
            //    //abp.ui.clearBusy(_$modal);
            //});

            //调用abp的ajax方法
            abp.ajax({
                url: '/Roles/UpdateRoleInfos',
                data: JSON.stringify(role) //转换成json字符串
            }).done(function (data) {
                debugger
                if (data.Data.success) {
                    abp.notify.success('添加成功');
                    location.reload(true);
                }
                else {
                    abp.notify.error('添加失败');
                }
            });
        })
    });
})();