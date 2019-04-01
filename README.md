# GrowthPolicies APP

Para esta prueba se trabajo con Visual Studio 2019 con .NET Framework 4.7.2, Entity Framework, Angular CLI 7.3.6, NG-ZORRO(Ant Design of Angular) y Angular 7,MS SQL 2017 con Docker.

## NOTA:
La prueba NO está 100% terminada, faltaron funcionalidades.

# Pendientes:
-La app actualmente solo funciona en modo administrador por lo que se recomienda que se cree un usuario y manualmente se establesca el rol como administrador.

-Se creó la ventana de Login,Registrar usuario, Clientes(Permite eliminar), Crear Polizas (Crear y Actualizar), falta el resto de formularios.

-No se cuenta con un correcto manejo de la autenticación( la idea era agregar un CanActivate), solo se manejo mediante Local Storage.

-Manejo correcto de excepciones.

-La inyección de dependencias se trató de hacer con Ninject, se creó archivo para el manejo en todas las capas, pero al no funcionar correctamnente y por tiempo se omitió  en controllers.

-Pruebas unitarias quedaron pendientes, al igual las pruebas de integración.

## Estas son las capturas de la aplicación
Este es el formulario para crear un usuario ruta http://localhost:4200/pages/register:
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/0.JPG)

Esta captura muestra el manejo de error con una notificación
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/1.JPG)

Esta captura muestra el mensaje satisfactorio con una notificación
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/2.JPG)

Esta captura muestra la página de login con error
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/3.JPG)

Esta captura muestra la página de login http://localhost:4200/pages/login
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/4.JPG)

Esta captura muestra la página de home http://localhost:4200/dashboard/home
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/5.JPG)

Esta captura muestra la página de clients http://localhost:4200/dashboard/clients
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/6.JPG)

Esta captura muestra como se elimina un usuario:
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/7.JPG)

Esta captura muestra como se elimina un usuario y el proceso es exitoso:
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/8.JPG)

Esta captura muestra la página de Crear Poliza http://localhost:4200/dashboard/create-policy
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/9.JPG)

Esta captura muestra  alerta con lo que es una poliza de alto riesgo debe elegir una covertura baja en porcentaje
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/10.JPG)

Esta captura muestra alerta cuando se guarda una poliza
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/11.JPG)

Esta captura muestra  alerta con lo que es una poliza de alto riesgo debe elegir una covertura baja en porcentaje desde el backend
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/12.JPG)

Se agrego swagger al proyeto para facilitar las pruebas de desarrollo y la documentación de las APIS.
![Step0](https://raw.githubusercontent.com/gersof/GrowthPolicies/master/Images/13.JPG)
