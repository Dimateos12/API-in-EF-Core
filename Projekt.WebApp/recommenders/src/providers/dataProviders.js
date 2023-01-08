import axios from 'axios';
import { useState } from 'react';
import App from '../App';
import { setAuthToken } from './setAuthToken';


const API_URL = 'https://localhost:7146/api/';




export function Login(data){
    axios.post(API_URL+'Authentication/Login',data)
    .then(response =>{
        const token = response.data.token;

        localStorage.setItem("token", token);

        setAuthToken(token);
        window.location.href = '/mainPage'
    })
    .catch(err => console.log(err));
};

export function Register(data){
    axios.post(API_URL+'Authentication/Register',data)
    .then(response =>{
        window.location.href = '/singin'
    })
    .catch(err => console.log(err));
};

export function UserRanking(){
    axios.get(API_URL+'User/rank')
    .then(response =>{
       
      });      
};