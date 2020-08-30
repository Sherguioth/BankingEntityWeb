
package webservices;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for updateProductoRegistration complex type.
 *
 * <p>The following schema fragment specifies the expected content contained within this class.
 *
 * <pre>
 * &lt;complexType name="updateProductoRegistration">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="arg0" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="arg1" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="arg2" type="{http://webServices/}productRegistration" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 *
 *
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "updateProductoRegistration", propOrder = { "arg0", "arg1", "arg2" })
public class UpdateProductoRegistration {

    protected int arg0;
    protected int arg1;
    protected ProductRegistration arg2;

    /**
     * Gets the value of the arg0 property.
     *
     */
    public int getArg0() {
        return arg0;
    }

    /**
     * Sets the value of the arg0 property.
     *
     */
    public void setArg0(int value) {
        this.arg0 = value;
    }

    /**
     * Gets the value of the arg1 property.
     *
     */
    public int getArg1() {
        return arg1;
    }

    /**
     * Sets the value of the arg1 property.
     *
     */
    public void setArg1(int value) {
        this.arg1 = value;
    }

    /**
     * Gets the value of the arg2 property.
     *
     * @return
     *     possible object is
     *     {@link ProductRegistration }
     *
     */
    public ProductRegistration getArg2() {
        return arg2;
    }

    /**
     * Sets the value of the arg2 property.
     *
     * @param value
     *     allowed object is
     *     {@link ProductRegistration }
     *
     */
    public void setArg2(ProductRegistration value) {
        this.arg2 = value;
    }

}