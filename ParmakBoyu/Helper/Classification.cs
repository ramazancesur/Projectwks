using System;
using weka.classifiers;
using weka.core;

namespace ParmakBoyu.Helper
{
    class Classification
    {
        #region generalValue
        static weka.classifiers.Classifier cl;
        #endregion

        public Classification()
        {

        }

        public static string PredictBlood(string path)
        {
            int percentSplit = 100;
            try
            {
                weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(path));
                insts.setClassIndex(insts.numAttributes() - 1);

                weka.classifiers.Classifier cl = new weka.classifiers.bayes.NaiveBayes();
                //Knn algoritması uygulanıyor

                //randomize the order of the instances in the dataset.
                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100 - 1;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);
                /// string[] dizi;
                cl.buildClassifier(train);
                //int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    // double predictedClass = cl.classifyInstance(currentInst);
                    if (i == insts.numInstances() - 1)
                    {
                        double predictedClass = cl.classifyInstance(currentInst);
                        if (predictedClass == 1)
                        {
                            return "A grubu";
                        }
                        else if (predictedClass == 0)
                        {
                            return "0 grubu";
                        }
                        else if (predictedClass == 2)
                        {
                            return "B grubu";
                        }
                        else if (predictedClass == 3)
                        {
                            return "AB grubu";
                        }
                    }
                }

            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
            }
            return "hata";
        }
  
        public static double GroupTest(string path,int trainRatio)
        {
            double sayi = 0;
            try
            {
                weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(path));
                insts.setClassIndex(insts.numAttributes() - 1);

                weka.classifiers.Classifier cl = new weka.classifiers.bayes.NaiveBayes();
                //Knn algoritması uygulanıyor

                //randomize the order of the instances in the dataset.
                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                Evaluation eval = new Evaluation(insts);

                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * trainRatio / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);
                weka.core.Instances test = new Instances(insts, trainSize, insts.size() - trainSize);
                cl.buildClassifier(train);
                eval.evaluateModel(cl, test);
                double deger=Math.Round(1 - eval.errorRate(), 4) * 100;
                return deger;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
            }
            return sayi;
        }

        public static double CrossValidation(string path, int folds)
        {
            try
            {
                java.util.Random rand = new java.util.Random(2000);
                weka.core.Instances insts = new weka.core.Instances(new java.io.FileReader(path));
                Instances randData = insts;
                randData.randomize(rand);
                cl = new weka.classifiers.bayes.NaiveBayes();
                insts.setClassIndex(insts.numAttributes() - 1);
                if (randData.classAttribute().isNominal())
                    randData.stratify(folds);

                // perform cross-validation
                Evaluation eval = new Evaluation(randData);
                for (int n = 0; n < folds; n++)
                {
                    Instances train = randData.trainCV(folds, n,new java.util.Random(4000));
                    Instances test = randData.testCV(folds, n);
                    cl.buildClassifier(train);
                    eval.evaluateModel(cl, test);
                }
                return Math.Round(1 - eval.errorRate(), 4) * 100;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
            }
            return 0;
        }
    }
}
