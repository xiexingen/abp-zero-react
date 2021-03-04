import { IBestAFSRoute } from '@umijs/plugin-layout';

/**
 * 权限定义
 */
const Permissions = {
  template: {
    dashboard: {
      index: 'template.dashboard',
    },
    sample: {
      index: 'template.sample',
      list: {
        index: 'template.sample.list',
        edit: 'template.sample.list.edit',
        delete: 'template.sample.list.delete',
      },
    },
  },
};

// umi routes: https://umijs.org/zh/guide/router.html
const routes: IBestAFSRoute[] = [
  {
    path: '/account',
    layout: false,
    routes: [
      {
        path: '/account',
        redirect: 'login',
      },
      {
        name: '登录',
        path: 'login',
        component: '@/pages/account/login/index',
      },
    ],
  },
  {
    path: '/template',
    // menu: {
    //   name: 'Wetrial',
    //   icon:''
    // },
    flatMenu: true,
    routes: [
      {
        path: '/template',
        redirect: 'dashboard',
      },
      {
        path: 'dashboard',
        name: '看板',
        icon: 'dashboard',
        access: Permissions.template.dashboard.index,
        component: '@/pages/template/dashboard/index',
      },
      {
        path: 'sample',
        name: '案例',
        access: 'isAdmin',
        icon: 'smile',
        routes: [
          {
            path: 'list',
            name: '列表',
            access: Permissions.template.sample.list.index,
            menu: {
              hideChildren: true,
            },
            routes:[
              {
                path: '/template/sample/list',
                redirect: 'index',
              },
              {
                path: 'index',
                access: Permissions.template.sample.list.index,
                component: '@/pages/template/sample/list/index',
              },
              {
                path: 'edit/:id?',
                component: '@/pages/template/sample/list/edit',
                access: Permissions.template.sample.list.edit,
              },
            ]
          },
          {
            path: 'tabs-share',
            name: '共享Tab',
            access: Permissions.template.sample.list.index,
            component:'@/pages/template/sample/tabs-share/index'
          },
          {
            path:'tree-form',
            name:'tree-form',
            access: Permissions.template.sample.list.index,
            component:'@/pages/template/sample/tree-form/index'
          },
          {
            path: 'dict',
            name:'数据字典',
            access: Permissions.template.sample.list.index,
            component: '@/pages/template/sample/dict/index',
          },
        ],
      },
      {
        component: '@/pages/exception/404',
      },
    ],
  },
  {
    path: '/',
    redirect: '/template',
  },
  {
    component: '@/pages/exception/404',
  },
];

export default routes;
export { Permissions };

