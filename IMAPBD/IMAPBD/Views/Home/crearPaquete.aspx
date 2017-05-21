<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>IMAPDB - Empresa - Crear paquete</title>

    <!-- Bootstrap -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" rel="stylesheet">
    <link href="Views/Home/res/css/font-awesome.min.css" rel="stylesheet">
    <link href="Views/Home/res/css/custom.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    
</head>
<body>
    <header>
        
        <div class="container">
            
            <div class="row">
                
                <div class="col-xs-8"><h1>IMAPDB</h1></div>
                <div class="col-xs-4"><i class="fa fa-sign-out fa-2x pull-right" aria-hidden="true"></i></div>
                
            </div>
            
            <div class="row menu">
                
                <div class="col-md-6 col-xs-12">
                    <ul>
                        <li><a href="index.html">Inicio</a></li>
                        <li><a href="crear-paquete.html">Crear paquetes</a></li>
                        <li><a href="lugares.html">Lugares</a></li>
                    </ul>
                </div>
                <div class="col-md-6 col-xs-12">
                   <div class="pull-right">
                    <form class="form-inline busqueda">
                        
                        <div class="form-group ">
                            <input type="search" class="form-control" id="inputBuscar" placeholder="Buscar paquete">
                        </div>
                        <button type="submit" class="btn btn-primary">Buscar</button>
                    </form>
                </div>
                    
                </div>
                
            </div>
            
        </div>
        
    </header>
    
    <div>
        
        <div class="container">

            <div class="row">
                
                <div class="col-md-5 col-xs-12">
                    <h2>Crear paquetes</h2>
                    <!-- On rows -->
                    
                </div>
                
                <div class="col-md-7 col-xs-12">
                    <button type="submit" class="btn btn-success pull-right">Publicar paquete</button>
                </div>
                
            </div>
            
            <div class="row">
                
                <div class="col-md-5 col-xs-12">
                    <form>
                    <div class="form-group">
                        <textarea class="form-control" id="cp-informacion" placeholder="Información general"></textarea>
                    </div>
                    
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-tipo" placeholder="Tipo">
                    </div>
                    
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-origen" placeholder="Origen">
                    </div>
                    
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-destino" placeholder="Destino">
                    </div>
                    
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-fechasalida" placeholder="Fecha de salida">
                    </div>
                    
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-fechallegada" placeholder="Fecha de llegada">
                    </div>
                        
                    <div class="form-group">
                        <input type="email" class="form-control" id="cp-fechavencimiento" placeholder="Fecha de vencimiento">
                    </div>
                    
                    <div class="row">
                        
                        <div class="col-xs-6">
                            <div class="form-group">
                                <input type="email" class="form-control" id="cp-costo" placeholder="Costo">
                            </div>
                        </div>
                        <div class="col-xs-6">
                            <div class="form-group">
                                <input type="email" class="form-control" id="cp-moneda" placeholder="Moneda">
                            </div>
                        </div>
                        
                    </div>
                        
                    <div class="form-group">
                        <label for="exampleInputFile">Subir imagen</label>
                        <input type="file" id="exampleInputFile">
                        <p class="help-block">Solo se permiten archivos JPG y PNG de no más de 5mb.</p>
                    </div>
                    </form>
                    
                </div>
                
                <div class="col-md-7 col-xs-12">
                    <h3>Actividades</h3>
                    <div class="table-responsive">
                        <table class="table table-condensed table-hover">

                            <!--<tr>
                            <td class="active">Cotizaciones</td>
                            <td class="success">Origen</td>
                            <td class="warning">Destino</td>
                            <td class="danger">estatus</td>
                            </tr>-->
                            <thead>                            
                                <tr>
                                    <td>Tipo</td>
                                    <td>Origen</td>
                                    <td>Destino</td>
                                    <td>Fecha salida</td>
                                    <td>Fecha llegada</td>
                                    <td>Costo</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Viaje</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                                <tr>
                                    <td>Paseo</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                                <tr>
                                    <td>Estadia</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <form>
                        <h3>Crear actividad</h3>
                        <div class="row">
                        
                            <div class="col-xs-6">
                                <!--<div class="form-group">
                                    <textarea class="form-control" id="ca-informacion" placeholder="Información general"></textarea>
                                </div>-->
                                
                                <div class="form-group">
                                    <select class="form-control">
                                      <option>Viaje</option>
                                      <option>Lima</option>
                                      <option>Estadia</option>
                                    </select>
                                </div>
                                
                                <div class="form-group">
                                    <input type="email" class="form-control" id="cp-fechasalida" placeholder="Origen">
                                </div><div class="form-group">
                                    <input type="email" class="form-control" id="cp-fechasalida" placeholder="Destino">
                                </div>
                                
                                
                                
                            </div>
                            
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <input type="email" class="form-control" id="cp-fechasalida" placeholder="Fecha salida">
                                </div>
                                
                                <div class="form-group">
                                    <input type="email" class="form-control" id="cp-fechasalida" placeholder="Fecha llegada">
                                </div>
                                
                                <div class="row">
                                
                                    <div class="col-xs-6">
                                        <div class="form-group">
                                            <input type="email" class="form-control" id="cp-fechasalida" placeholder="Costo">
                                        </div>
                                    </div>
                                    <div class="col-xs-6">
                                        <div class="form-group">
                                            <input type="email" class="form-control" id="cp-fechasalida" placeholder="Moneda">
                                        </div>
                                    </div>
                                
                                </div>
                                
                                
                                
                                
                                <div class="form-group">
                                    <button type="submit" class="btn btn-primary pull-right">Agregar actividad</button>
                                </div>
                            </div>
                            
                        </div>
                        
                        
                        
                    </form>
                </div>
                
            </div>
            
        </div>
        
    </div>
    
    <footer>
        <div class="container">
            <row>
                <div class="col-xs-12">
                    IMAPDB. 2017
                </div>
            </row>
        </div>
    </footer>
    
    
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
</body>
</html>
