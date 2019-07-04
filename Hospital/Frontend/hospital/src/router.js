import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Paciente from './components/Paciente.vue'
import Orden from './components/Orden.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/pacientes',
      name: 'pacientes',
      component: Paciente
    },
    {
      path: '/ordenes',
      name: 'ordenes',
      component: Orden
    }
  ]
})
