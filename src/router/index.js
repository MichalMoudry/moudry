import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '@/views/HomeView.vue'
import SkillsView from '@/views/SkillsView.vue'
import SpsView from '@/views/SpsView.vue'
import Vse1View from '@/views/Vse1View.vue'
import Vse2View from '@/views/Vse2View.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/skills',
      name: 'skills',
      component: SkillsView
    },
    {
      path: '/sps',
      name: 'sps',
      component: SpsView
    },
    {
      path: '/vse1',
      name: 'vse1',
      component: Vse1View
    },
    {
      path: '/vse2',
      name: 'vse2',
      component: Vse2View
    }
  ]
})

export default router
