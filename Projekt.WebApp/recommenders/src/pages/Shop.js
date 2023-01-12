import logo from "./face.jpg";


export default function Shop() {
    const size = 40;

    return (
        <>
            <section class="py-5">
               
                <div class="container px-4 px-lg-5 mt-5">
                <h1>Nasze produkty</h1>
                    <div class="row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center">
                {Array(size).fill().map((x, i) =>
                        <div class="col mb-5"  key={i}>
                            <div class="card h-200 bg-image hover-zoom">
                           
                                <img class="card-img-top w-100"src={logo} alt="logo" />
                             
                                <div class="card-body p-4">
                                    <div class="text-center">
                             
                                        <h5 class="fw-bolder">Produkt</h5>
                                        
                                       OPIS TUTAJ 
                                    </div>
                                </div>
                            
                                <div class="card-footer p-4 pt-0 border-top-0 bg-transparent">
                                    <div class="text-center"> <a class="btn btn-outline-dark mt-auto" href="/product">Check product</a></div>
                                </div>
                            </div>
                        </div>
                )}

                    </div>
                </div>
            </section>
        </>
    );

}