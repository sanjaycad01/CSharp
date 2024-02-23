namespace goverment{
    class Brightservice{
        string batch_mrg,batch_eve,batch_nig;

         public Brightservice()
         {
            batch_mrg="Artificial Intelligence";
            batch_eve="Cloud Application";
            batch_nig="US Calling";
            
         }

         public string  getbatch_mrg(){
            return batch_mrg;
         }
          public string getbatch_eve(){
            return batch_eve;
         }
          public string getbatch_nig(){
            return batch_nig;
         }

    }
}